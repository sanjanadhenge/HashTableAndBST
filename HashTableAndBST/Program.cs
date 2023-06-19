using HashTableAndBST;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStruct
{
    internal class program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(5);
            myMapNode.Add("0", "Paranoids");
            myMapNode.Add("0", "are");
            myMapNode.Add("0", "not");
            myMapNode.Add("0", "because");
            myMapNode.Add("0", "they");
            myMapNode.Add("0", "are");
            myMapNode.Add("0", "paranoid");
            myMapNode.Add("0", "but");
            myMapNode.Add("0","beacause");
            myMapNode.Add("0", "they");
            myMapNode.Add("0", "keep");
            myMapNode.Add("0", "putting");
            myMapNode.Add("0", "themselves");
            myMapNode.Add("0", "deliberately");
            myMapNode.Add("0", "into");
            myMapNode.Add("0", "paranoid");
            myMapNode.Add("0", "avoidable");
            myMapNode.Add("0", "situations");
            // myMapNode.FindFrequency("0", "paranoid");
            myMapNode.Remove("0", "avoidable");
        }
    }
}