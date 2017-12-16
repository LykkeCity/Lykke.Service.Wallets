﻿
using Lykke.Service.Balances.Core.Domain.Wallets;

namespace Lykke.Service.Balances.Models.ClientBalances
{
    public class ClientBalanceResponseModel
    {
        public string AssetId { get; set; }
        public double Balance { get; set; }
        public double Reserved { get; set; }

        public static ClientBalanceResponseModel Create(IWallet src)
        {
            return new ClientBalanceResponseModel
            {
                AssetId = src.AssetId,
                Balance = src.Balance,
                Reserved = src.Reserved
            };
        }
    }
}
