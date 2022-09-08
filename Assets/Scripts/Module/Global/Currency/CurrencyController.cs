using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Agate.MVC.Base;

namespace Trivia.Currency
{
    public class CurrencyController : DataController<CurrencyController, CurrencyModel>
    {
        public int GetCoin()
        {
            return 1;
        }

        public void AddCoin(int amount)
        {
            _model.AddCoin(amount);
        }

        public bool SpendCoin(int amount)
        {
            return _model.SpendCoin(amount);
        }
    }

}
