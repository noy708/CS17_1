using System;

namespace CS17_1
{
    internal class Nickname
    {
        private string[] nicknames =
        {
            "スリッパ","手ぬぐい","PHS","キッチンペーパー","DVDレコーダー","地下鉄","トマトケチャップ"
        };
        public string Name { get; internal set; }
        public int Age { get; internal set; }

        public string GetNickName()
        {
            int i = Name.Length + Age;
            int r = i % nicknames.Length;
            return nicknames[r];
        }
    }
}