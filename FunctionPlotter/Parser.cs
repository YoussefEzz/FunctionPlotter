using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPlotter
{
    public class Parser
    {
        Token m_token;
        Scanner m_scanner;
        int m_var;

        public Parser(Scanner scanner)
        {
            m_scanner = scanner;
        }

        void match(TokenType expected)
        {
            if(m_token.tokenType.Equals(expected))
            {
                m_token = m_scanner.getToken();
            }
            else
            {

            }
        }

        public int parse(int var)
        {
            m_var = var;
            int result = 0;
            m_token = m_scanner.getToken();
            
            result = addsubexp();
            m_scanner.resetToken();

            return result;
        }

        int addsubexp()
        {
            int temp = muldivexp();
            while (m_token.tokenType.Equals(TokenType.Plus) || m_token.tokenType.Equals(TokenType.Minus))
            {
                if (m_token.tokenType.Equals(TokenType.Plus))
                {
                    match(TokenType.Plus);
                    temp += muldivexp();
                }
                else if (m_token.tokenType.Equals(TokenType.Minus))
                {
                    match(TokenType.Minus);
                    temp -= muldivexp();
                }
            }
            return temp;
        }

        int muldivexp()
        {
            int temp = powerexp();
            while(m_token.tokenType.Equals(TokenType.Times) || m_token.tokenType.Equals(TokenType.Divide))
            {
                if(m_token.tokenType.Equals(TokenType.Times))
                {
                    match(TokenType.Times);
                    temp *= powerexp();
                }
                else if(m_token.tokenType.Equals(TokenType.Divide))
                {
                    match(TokenType.Divide);
                    temp /= powerexp();
                }
            }
            return temp;
        }

        int powerexp()
        {
            int temp = exp();
            if (m_token.tokenType.Equals(TokenType.Power))
            {
                match(TokenType.Power);
                temp = (int)Math.Pow(temp, powerexp());
            }
            
            return temp;
        }

        int exp()
        {
            int temp = 0;
            if(m_token.tokenType.Equals(TokenType.Number))
            {
                temp = int.Parse(m_token.tokenString);
                match(TokenType.Number);
            }
            else if(m_token.tokenType.Equals(TokenType.Identifier))
            {
                temp = m_var;
                match(TokenType.Identifier);
            }
            else if (m_token.tokenType.Equals(TokenType.LParen))
            {
                match(TokenType.LParen);
                temp = addsubexp();
                match(TokenType.RParen);
            }
            else
            {

            }

            return temp;
        }
    }
}
