using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionPlotter
{
    public enum TokenType {None, Identifier, Number, Plus, Minus, Times, Divide, Power, LParen, RParen, Error, EOT };
    public enum StateType { Start, Number, Done };

    public struct Token
    {
       public TokenType tokenType;
       public string tokenString;
    }

    public class Scanner
    {
        string m_function;
        int m_charpos;
        List<Token> m_tokenlist ;

        public Scanner(string function)
        {
            m_function = function;
            m_charpos = 0;
            m_tokenlist = new List<Token>();
        }

        public Token getToken()
        {
            StateType state = StateType.Start;
            Token currentToken = new Token();

            while (state != StateType.Done)
            {
                char c = getNextCharacter();

                switch (state)
                {
                    case StateType.Start:
                        currentToken.tokenString = "";
                        if (Char.IsDigit(c))
                        {
                            currentToken.tokenType = TokenType.Number;
                            currentToken.tokenString += c;
                            state = StateType.Number;
                        }
                        else if(c.Equals('x'))
                        {
                            currentToken.tokenType = TokenType.Identifier;
                            currentToken.tokenString += c;
                            state = StateType.Done;
                        }
                        else if(c.Equals('+'))
                        {
                            currentToken.tokenType = TokenType.Plus;
                            currentToken.tokenString += c;
                            state = StateType.Done;
                        }
                        else if (c.Equals('-'))
                        {
                            currentToken.tokenType = TokenType.Minus;
                            currentToken.tokenString += c;
                            state = StateType.Done;
                        }
                        else if (c.Equals('*'))
                        {
                            currentToken.tokenType = TokenType.Times;
                            currentToken.tokenString += c;
                            state = StateType.Done;
                        }
                        else if (c.Equals('/'))
                        {
                            currentToken.tokenType = TokenType.Divide;
                            currentToken.tokenString += c;
                            state = StateType.Done;
                        }
                        else if (c.Equals('^'))
                        {
                            currentToken.tokenType = TokenType.Power;
                            currentToken.tokenString += c;
                            state = StateType.Done;
                        }
                        else if (c.Equals('('))
                        {
                            currentToken.tokenType = TokenType.LParen;
                            currentToken.tokenString += c;
                            state = StateType.Done;
                        }
                        else if (c.Equals(')'))
                        {
                            currentToken.tokenType = TokenType.RParen;
                            currentToken.tokenString += c;
                            state = StateType.Done;
                        }
                        else if(c.Equals('\0'))
                        {
                            currentToken.tokenType = TokenType.EOT;
                            currentToken.tokenString += c;
                            state = StateType.Done;
                        }
                        else
                        {

                        }
                        break;
                    case StateType.Number:
                        if (Char.IsDigit(c))
                        {
                            currentToken.tokenString += c;
                        }
                        else if (c.Equals('\0'))
                        {
                            state = StateType.Done;
                        }
                        else
                        {
                            ungetNextCharacter();
                            state = StateType.Done;
                        }
                        break;
                    case StateType.Done:
                        break;
                    default:
                        break;
                    
                }                
            }
            //printToken(currentToken);
            return currentToken;
        }

        public void resetToken()
        {
            m_charpos = 0;
        }

        void printToken(Token token)
        {
           utility.scanner_writer.WriteLine(token.tokenType.ToString() + " , " + token.tokenString);
        }        

        char getNextCharacter()
        {
            if (m_charpos < m_function.Length)
                return m_function[m_charpos++];
            else
                return '\0';
        }

        void ungetNextCharacter()
        {
            m_charpos--;
        }
    }
}
