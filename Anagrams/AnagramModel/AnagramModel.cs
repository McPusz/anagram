using System;
namespace Anagrams
{
    public class AnagramModel
    {
        public string[] options { get; set; }

        public AnagramModel(string[] options)
        {
            this.options = options;
        }

    }
}
