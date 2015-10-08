using System.Collections.Generic;

namespace _01.Game_Frame
{
    public class LevelOneDialogs
    {
        public static Dictionary<string, List<string>> levelOneDialogOne() {
            Dictionary <string, List <string>> DialogOne = new Dictionary<string, List<string>>();

            DialogOne.Add(
                "Guard",
                new List<string> {
                    @"Bah! Who are you? Why are you in the dungeon?",
                    @"Think yourself clever, huh? We'll see how clever you are once the master takes you to the torture chamber.",
                    @"Oh, yes, the torture chamber. You see, the master has the most refined methods of torturing his captives...",
                    @"Well, there are the torture racks, iron chairs and breaking wheels...",
                    @"If you think you're very tough, we'll see how you'll fare with the Poena Finalis! That's not enough for you, eh? But that's not the worst of it by far.",
                    @"That's not what Poena Finalis is, you fool, no! ( He pauses for a bit and continues in a hushed voice.)He will make you decline Latin nouns!",
                    @"But wait! If it's not me, then it must be the master who put you here.",
                    @"Haha, do you mean to scare me, prisoner? It's you who will rot in this cell… ",
                    @"Oh, I know better than to talk about the master. You will not trick me. The master will reveal himself to you when he decides.",
                });

            DialogOne.Add(
                "Player",
                new List<string> {
                    @" You are some gaoler if you don't even know the prisoners you are guarding.",
                    @" Torture chamber?",
                    @" Such as?",
                    @" Hmpf!",
                    @" The what? Let me tell you, I've never in my life caught any veneric diseases...",
                    @" My god, no! What monster is this master of yours?!  All I remember is I got hit on the head…",
                    @" I am a powerful mage and unless you release me this moment, I'll have your blood boil and burn you from the inside.",
                    @" Who is this master of yours?",
                    @" Wait, I still have to ask...",
                });
            return DialogOne;          
        }        
    }
}
