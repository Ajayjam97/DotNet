using System;
using static Newtonsoft.Json.JsonConvert;

namespace Library
{
    public class Answer
    {
        public int GetAnswer(int left, int right) =>
            DeserializeObject<int>($"{left + right}");  
    }
}
