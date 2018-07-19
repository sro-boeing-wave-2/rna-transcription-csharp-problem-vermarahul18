using System;
using System.Collections.Generic;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            Dictionary<char, string> comp = new Dictionary<char, string>();
            comp.Add('G',"C");
            comp.Add('C',"G");
            comp.Add('T',"A");
            comp.Add('A',"U");
            string rna = "";

            for (int i = 0; i < nucleotide.Length; i++) {
                rna += comp[nucleotide[i]];
            }
            //added a comment;
            return rna;
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
