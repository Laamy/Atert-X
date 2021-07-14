using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atert_X.gameClasses
{
    public class ItemRegistry
    {
        public static int getIDFromName(string itemID)
        {
            string upperID = itemID.ToUpper();
            if (upperID == "BEHEMUTTIUM") return 0;
            if (upperID == "COLLECTOR BOT") return 1;
            if (upperID == "IRON ORE") return 2;
            if (upperID == "MEDKIT") return 3;
            // No ID 4 Oof
            if (upperID == "STONE") return 5;
            if (upperID == "TWIG") return 6;
            if (upperID == "WATER BALL") return 7;
            if (upperID == "FIGHTER BOT") return 8;
            if (upperID == "COPPER ORE") return 9;
            if (upperID == "CHARCOAL") return 10;
            if (upperID == "COPPER INGOT") return 11;
            if (upperID == "IRON INGOT") return 12;
            if (upperID == "BERRY") return 13;
            if (upperID == "ANIMAL BONE") return 14;
            if (upperID == "NUTRITIOUS EGG") return 15;
            if (upperID == "CACTUS FLOWER") return 16;
            if (upperID == "SAND") return 17;
            if (upperID == "SWEETCANE") return 18;
            if (upperID == "STEEL") return 19;
            if (upperID == "MODULAR BRICK") return 20;
            if (upperID == "GLASS") return 21;
            if (upperID == "LOGISTICS BOT") return 22;
            if (upperID == "RIFLE CLIP") return 23;
            if (upperID == "OXYGEN BOTTLE") return 24;
            if (upperID == "ADVANCED RIFLE CLIP") return 25;

            if (upperID == "BERRY BUSH SAPLING") return 141;
            if (upperID == "CACTUS SAPLING") return 142;
            if (upperID == "WATER PLANT SAPLING") return 143;

            if (upperID == "SWEETCANE SEED") return 145;
            if (upperID == "TWING SEED") return 146;

            if (upperID == "ANIMAL POOP") return 149;

            if (upperID == "PLASTIC") return 157;

            if (upperID == "STRETSHROOM SPORES") return 163;
            if (upperID == "STRETSHROOM") return 164;

            if (upperID == "BOT HEALING MODULE") return 166;
            if (upperID == "BOT SPEED MODULE") return 167;

            if (upperID == "CORNILIA FLOWER") return 197;

            if (upperID == "CORNILIA FLOWER SEED") return 199;

            if (upperID == "CORNILIA FLOWER SEED") return 199;

            if (upperID == "BUGGED ITEM") return 10000;

            return -1;
        }
    }
}
