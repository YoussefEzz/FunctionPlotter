using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPlotter
{
    /// <summary>
    /// class that parses the function string according to given grammar
    /// </summary>
    public class Parser
    {
        Token m_token;
        Scanner m_scanner;
        int m_var;

        /// <summary>
        /// parser constructor
        /// </summary>
        /// <param name="scanner">scanner object to get the tokens</param>
        public Parser(Scanner scanner)
        {
            m_scanner = scanner;
        }

        /// <summary>
        /// function to obtain next token if the current token is the expected one otherwise error occurs
        /// </summary>
        /// <param name="expected">expected token</param>
        void match(TokenType expected)
        {
            if(m_token.tokenType.Equals(expected))
            {
                m_token = m_scanner.getToken();
            }
            else
            {
                error();
            }
        }

        /// <summary>
        /// function to throw an exception if an error occurs in syntax
        /// </summary>
        void error()
        {
            string errormessage = "unexpected token : " + m_token.tokenString + ".";
            Console.WriteLine(errormessage);
            throw new Exception(errormessage);
        }

        /// <summary>
        /// function to reset character position in scanner
        /// </summary>
        public void reset()
        {
            m_scanner.resetToken();
        }

        /// <summary>
        /// main function that parses the function string and calculates its value according to input
        /// </summary>
        /// <param name="x">variable value</param>
        /// <returns>int value representing net value of the function</returns>
        public int parse(int x)
        {
            m_var = x;
            int result = 0;
            m_token = m_scanner.getToken();
            
            result = addsubexp();
            reset();

            return result;
        }

        /// <summary>
        /// recursive function that represent addition and subtraction expressions according to rule
        /// addsubexp -> addsubexp  addop muldivexp | muldivexp
        /// </summary>
        /// <returns>int value of the result of addsub expression</returns>
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

        /// <summary>
        /// recursive function that represent multiplication and division expressions according to rule
        /// muldivexp -> muldivexp mulop powerexp | powerexp
        /// </summary>
        /// <returns>int value of the result of muldiv expression</returns>
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

        /// <summary>
        /// recursive function that represent power expressions according to rule
        /// powerexp -> exp powerop powerexp | exp
        /// </summary>
        /// <returns>int value of the result of power expression</returns>
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

        /// <summary>
        /// normal expression representing identifier or number or addsub expression within parentheses according to rule
        /// exp -> (addsubexp ) | identifier | number
        /// </summary>
        /// <returns>int value of the result of normal expression</returns>
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
                error();
            }

            return temp;
        }
    }
}
