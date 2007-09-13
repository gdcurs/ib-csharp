using System;
using System.Collections.Generic;
using System.Text;
using Krs.Ats.IBNet;

namespace Krs.Ats.IBNet.Contracts
{
    /// <summary>
    /// Create a contract with the default parameters for an indice
    /// </summary>
    /// <seealso cref="Contract"/>
    public class Indice : Contract
    {
        /// <summary>
        /// Create an Indice Contract for a specific exchange
        /// </summary>
        /// <param name="symbol">Symbol for the indice contract. See <see cref="Contract.Symbol"/>.</param>
        /// <param name="exchange">Exchange for the indice contract. See <see cref="Contract.Exchange"/></param>
        public Indice(string symbol, string exchange)
            : base(symbol, exchange, SecurityType.Indice, "USD")
        {
        }
    }
}