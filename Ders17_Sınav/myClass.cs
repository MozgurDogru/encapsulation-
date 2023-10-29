using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ders17_Sınav
{
    public class myClass
    {

        private int _number1 { get; set; }

        public int  number1 {
            get
            {
                return _number1;
            }
            set
            {
                if (value<20)
                {
                    _number1 = 20;
                }

                else
                {
                        _number1 = value;
                }
            } 
        }
        private int _number2 { get; set; }

        public int number2
        {
            get
            {
                return _number2;
            }
            set
            {
                if (value < 20)
                {
                    _number2 = 20;
                }

                else
                {
                    _number2 = value;
                }
            }
        }

        public int dortislem(string islem) 
        {
            int answer = 0;
            if (islem == "Toplama")
            {
                answer = number1 + number2;
            }
            else if (islem =="Çıkarma")
            {
                if (number1>_number2)
                {
                    answer = number1 - number2;
                }

                else 
                {

                    answer = number2 - number1;
                }
            }
                 else if (islem == "Çarpma")
                 {
                    answer = number1 * number2;
                 }
                else
                {
                    if (number1>number2)
                    {
                        answer = number1 / number2;
                    }
                    else
                    {
                        answer= number2 / number1;  
                    }
                } return answer;
                 
            
        }
        
      
    }
}
