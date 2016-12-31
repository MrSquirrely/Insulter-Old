using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingApplication {
    class Insult {

        private static string[] Insults = new string[] {
            "Shut up, you'll never be the man your mother is.", //1
            "You're a failed abortion whose birth certificate is an apology from the condom factory.", //2
            "You must have been born on a highway, because that's where most accidents happen.", //3
            "Your family tree is a cactus, because everybody on it is a prick.", //4
            "You're so ugly Hello Kitty said goodbye to you.", //5
            "It looks like your face caught on fire and someone tried to put it out with a fork.", //6
            "You are so ugly that when your mama dropped you off at school she got a fine for littering.", //7
            "If you were twice as smart, you'd still be stupid.", //8
            "Do you have to leave so soon? I was just about to poison the tea.", //9
            "Your so ugly when you popped out the doctor said aww what a treasure and your mom said yeah lets bury it", //10
            "We all sprang from apes, but you didn't spring far enough.", //11
            "Dumbass.", //12
            "I hear when you were a child your mother wanted to hire somebody to take care of you, but the mafia wanted too much.", //13
            "When you were born, the police arrested your dad, the doctor slapped your mom, animal control euthanized your brother, and A&E made a documentary that saved your life.", //14
            "I'm not saying I hate you, but I would unplug your life support to charge my phone.", //15
            "Roses are red, violets are blue, I have 5 fingers, the 3rd one is for you.", //16
            "I'd like to see things from your point of view but I can't seem to get my head that far up my ass.", //17
            "Two wrongs don't make a right, take your parents as an example.", //18
            "If I wanted to kill myself I'd climb your ego and jump to your IQ.", //19
            "The only way you'll ever get laid is if you crawl up a chicken's ass and wait.", //20
            "If laughter is the best medicine, your face must be curing the world.", //21
            "Calling you an idiot would be an insult to all stupid people.", //22
            "I'm glad to see you're not letting your education get in the way of your ignorance.", //23
            "You are proof that evolution CAN go in reverse.", //24
            "Which sexual position produces the ugliest children? Ask your mother.", //25
            "I would love to insult you... but that would be beyond the level of your intelligence.", //26
            "Whats the difference between your girlfriend and a walrus? One has a moustache and smells of fish and the other is a walrus.", //27
            "As an outsider, what do you think of the human race?", //28
            "Do you wanna lose ten pounds of ugly fat? Cut off your head.", //29 
            "What would you call a woman who goes out with You? Desperate!" //30
        };

        public static string getInsult {
            get {
                Random rand = new Random();
                int INum = rand.Next(0,30);
                return Insults[INum];
            }
        }

    }
}
