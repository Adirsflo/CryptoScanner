using CryptoScanner.DAL.DataBase.DbContexts;
using CryptoScanner.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoScanner.DAL.DataBase
{
    public class DbManager
    {
        private readonly AppDbContext _context;


        public List<CoinRoot> GetAllCoins()
        {
            return _context.Coins.ToList();
        }

        public void AddCoinToDb(CoinRoot? coin)
        {
            if (coin == null) return;

            _context.Coins.Add(coin);
            _context.SaveChanges();
        }

        public CoinRoot? GetCoinById(int? id)
        {
            if (id == null) return null;
            if (id <= 0) return null;
            return _context.Coins.FirstOrDefault(coin => coin.Id == id);

        }

        public List<CoinRoot?>? RemoveCoinById(int? id)
        {
            if (id == null) return null;
            if (id <= 0) return null;

            CoinRoot? toDelete = _context.Coins.FirstOrDefault(coin => coin.Id == id);
            if (toDelete == null) return null;

            _context.Coins.Remove(toDelete);
            _context.SaveChanges();
            return GetAllCoins();

        }

        /// <summary>
        /// WILL DELETE ALL ENTRIES IN THE DATABASE
        /// </summary>
        public void RemoveAllCoins()
        {
            List<CoinRoot> allCoins = GetAllCoins();
            _context.Coins.RemoveRange(allCoins);
            _context.SaveChanges();
        }





        public DbManager(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

    }
}
