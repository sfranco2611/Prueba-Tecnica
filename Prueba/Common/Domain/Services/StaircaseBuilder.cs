using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class StaircaseBuilder : IStaircaseBuilder
    {
        public string CenterAlignedStaircaseBuilder(int size)
        {
            StringBuilder sb = new StringBuilder();
           
            if (size > 0 && size <100)
            {
                for (int i = 1; i <= size; i++)
                {
                    int numHashes = size + (i - 1) * 2;
                    sb.AppendLine(new string(' ', size - i) + new string('#', numHashes));
                }

                for (int i = size - 1; i >= 1; i--)
                {
                    int numHashes = size + (i - 1) * 2;
                    sb.AppendLine(new string(' ', size - i) + new string('#', numHashes));
                }
                return sb.ToString();
            }
            else
            {
                return "limite no valido";
            }
        }

        public string InvertedRightAlignedStaircaseBuilder(int size)
        {
            StringBuilder sb = new StringBuilder();

            if (size > 0 && size < 100)
            {
                for (int i = size; i >= 1; i--)
                {
                    sb.AppendLine(new string(' ', size - i) + new string('#', i));
                }
                return sb.ToString();
            }
            else 
            {
                return "limite no valido";
            }          
        }

        public string RightAlignedStaircaseBuilder(int size)
        {
            StringBuilder sb = new StringBuilder();

            if (size > 0 && size < 100)
            {
                for (int i = 1; i <= size; i++)
                {
                    sb.AppendLine(new string(' ', size - i) + new string('#', i));
                }
                return sb.ToString();
            }
            else
            {
                return "limite no valido";
            }
        }
    }
}
