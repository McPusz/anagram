using System;
namespace Anagrams
{
    public class LevelModel
    {
        public int levelNumber;
        public AnagramModel[] anagrams;

        public LevelModel(int levelNumber, AnagramModel[] anagrams)
        {
            this.levelNumber = levelNumber;
            this.anagrams = anagrams;
        }

    }
}
