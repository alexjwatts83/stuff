using FluentNHibernate.Domain.Models;

namespace FluentNHibernate.Console
{
    public static class MockData
    {
        public static Question q1 = CreateQuestion("Is the Animal Big?");
        public static Question q2 = CreateQuestion("Does the animal have a Tail?");
        public static Question q3 = CreateQuestion("Does the animal have a Trunk?");
        public static Question q4 = CreateQuestion("Does the animal have a Long Neck?");
        public static Question q5 = CreateQuestion("Can the animal Roar?");

        public static Characteristic c1 = CreateCharacteristic("Is Big.");
        public static Characteristic c2 = CreateCharacteristic("Has Tail.");
        public static Characteristic c3 = CreateCharacteristic("Has Trunk.");
        public static Characteristic c4 = CreateCharacteristic("Has Long Neck.");
        public static Characteristic c5 = CreateCharacteristic("Can Roar.");

        public static Question CreateQuestion(string text)
        {
            return new Question()
            {
                Text = text
            };
        }

        public static Characteristic CreateCharacteristic(string description)
        {
            return new Characteristic()
            {
                Description = description
            };
        }
    }
}