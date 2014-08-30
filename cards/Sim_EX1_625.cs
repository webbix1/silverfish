using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_EX1_625 : SimTemplate //shadowform
	{

//    eure heldenfähigkeit wird zu „verursacht 2 schaden“. wenn euer held bereits schattengestalt angenommen hat: 3 schaden.

        CardDB.Card mindspike = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_625t);
        CardDB.Card shatter  = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_625t2);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (ownplay)
            {
                if (p.ownHeroAblility.card.cardIDenum == CardDB.cardIDEnum.CS1h_001) // lesser heal becomes mind spike
                {
                    p.ownHeroAblility.card = mindspike;
                    p.ownAbilityReady = true;
                }
                else
                {
                    p.ownHeroAblility.card = shatter;  // mindspike becomes mind shatter
                    p.ownAbilityReady = true;
                }
            }
            else
            {
                if (p.enemyHeroAblility.card.cardIDenum == CardDB.cardIDEnum.CS1h_001) // lesser heal becomes mind spike
                {
                    p.enemyHeroAblility.card = mindspike;
                }
                else
                {
                    p.enemyHeroAblility.card = shatter;  // mindspike becomes mind shatter
                }
            }
		}

	}
}