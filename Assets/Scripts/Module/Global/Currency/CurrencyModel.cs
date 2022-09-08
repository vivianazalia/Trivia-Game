using Agate.MVC.Base;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Trivia.Currency
{
    public class CurrencyModel : BaseModel
    {
        public int Coin;

        public void AddCoin(int amount)
        {
            Coin += amount;
            SetDataAsDirty();
        }

        public bool SpendCoin(int amount)
        {
            if (Coin < amount) return false;

            Coin -= amount;
            SetDataAsDirty();
            return true;
        }
    }

}
