using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Trivia.Database
{
    [System.Serializable]
    //[CreateAssetMenu(fileName ="Level", menuName ="ScriptableObject/Level", order = 1)]
    public struct LevelStruct
    {
        public string levelID;
        public string packID;
        public string question;
        public string hint;
        public List<string> choices;
        public int answer;

        public LevelStruct(string _levelId, string _packId, string _question, string _hint, List<string> _choices, int _answer)
        {
            levelID = _levelId;
            packID = _packId;
            question = _question;
            hint = _hint;
            choices = _choices;
            answer = _answer;
        }

    }
}
