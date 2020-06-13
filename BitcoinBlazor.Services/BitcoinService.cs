using BitcoinBlazor.Data;
using BitcoinBlazor.Data.DataModels;
using Microsoft.EntityFrameworkCore;
using NBitcoin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BitcoinBlazor.Services
{
    public class BitcoinService : IBitcoinService
    {
        
        private readonly ApplicationDbContext _context;

        public BitcoinService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<UserBitcoinAddress>> GetAddresses(string userName)
        {
            return await _context.UserBitcoinAddresses.Where(user => user.UserName == userName).ToListAsync();
        }

        public async Task<UserBitcoinAddress> Add(UserBitcoinAddress bitcoinAddress) 
        {
            _context.UserBitcoinAddresses.Add(bitcoinAddress);
            await _context.SaveChangesAsync();
            return bitcoinAddress;
        }

        public async Task<UserBitcoinAddress> Update(UserBitcoinAddress bitcoinAddress)
        {
            _context.Entry(bitcoinAddress).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return bitcoinAddress;
        }

        public async Task<UserBitcoinAddress> Delete(int id)
        {
            var address = await _context.UserBitcoinAddresses.FindAsync(id);
            _context.UserBitcoinAddresses.Remove(address);
            await _context.SaveChangesAsync();
            return address;
        }

        /// <summary>
        ///     Generates a Bitcoin Private Key
        /// </summary>
        /// <returns>
        ///     privateKey, a Bitcoin private key.
        /// </returns>
        public Key GeneratePrivateKey()
        {
            Key privateKey = new Key();
            return privateKey;
        }

        /// <summary>
        /// Generates a Bitcoin Public Key from its associated Private Key
        /// </summary>
        /// <param name="privateKey">
        ///     The Private Key the Public Key is generated from
        /// </param>
        /// <returns>
        ///     A Bitcoin Public Key
        /// </returns>
        public PubKey GeneratePublicKey(Key privateKey)
        {
            PubKey publicKey = privateKey.PubKey;
            return publicKey;
        }

        /// <summary>
        ///     Gets a Legacy Bitcoin TestNet Address
        /// </summary>
        /// <param name="publicKey">
        ///     The Bitcoin Public Key
        /// </param>
        /// <returns>
        ///     A Legacy Bitcoin TestNet Address
        /// </returns>
        public BitcoinAddress GetLegacyBitcoinTestNetAddress(PubKey publicKey)
        {
            BitcoinAddress legacyBitcoinTestNetAddress = publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.TestNet);
            return legacyBitcoinTestNetAddress;
        }

        /// <summary>
        ///     Gets a Legacy Bitcoin MainNet Address
        /// </summary>
        /// <param name="publicKey">
        ///     The Bitcoin Public Key
        /// </param>
        /// <returns>
        ///     A Legacy Bitcoin MainNet Address
        /// </returns>
        public BitcoinAddress GetLegacyBitcoinMainNetAddress(PubKey publicKey)
        {
            BitcoinAddress legacyBitcoinMainNetAddress = publicKey.GetAddress(ScriptPubKeyType.Legacy, Network.Main);
            return legacyBitcoinMainNetAddress;
        }

        /// <summary>
        ///     Gets a Segwit Bitcoin TestNet Address
        /// </summary>
        /// <param name="publicKey">
        ///     The Bitcoin Public Key
        /// </param>
        /// <returns>
        ///     A Segwit Bitcoin TestNet Address
        /// </returns>
        public BitcoinAddress GetSegwitBitcoinTestNetAddress(PubKey publicKey)
        {
            BitcoinAddress segwitBitcoinTestNetAddress = publicKey.GetAddress(ScriptPubKeyType.Segwit, Network.TestNet);
            return segwitBitcoinTestNetAddress;
        }

        /// <summary>
        ///     Gets a Segwit Bitcoin MainNet Address
        /// </summary>
        /// <param name="publicKey">
        ///     The Bitcoin Public Key
        /// </param>
        /// <returns>
        ///     A Segwit Bitcoin MainNet Address
        /// </returns>
        public BitcoinAddress GetSegwitBitcoinMainNetAddress(PubKey publicKey)
        {
            BitcoinAddress segwitBitcoinMainNetAddress = publicKey.GetAddress(ScriptPubKeyType.Segwit, Network.Main);
            return segwitBitcoinMainNetAddress;
        }

        /// <summary>
        ///     Gets a SegwitP2SH Bitcoin TestNet Address
        /// </summary>
        /// <param name="publicKey">
        ///     The Bitcoin Public Key
        /// </param>
        /// <returns>
        ///     A SegwitP2SH Bitcoin TestNet Address
        /// </returns>
        public BitcoinAddress GetSegwitP2SHBitcoinTestNetAddress(PubKey publicKey)
        {
            BitcoinAddress segwitP2SHBitcoinTestNetAddress = publicKey.GetAddress(ScriptPubKeyType.SegwitP2SH, Network.TestNet);
            return segwitP2SHBitcoinTestNetAddress;
        }

        /// <summary>
        ///     Gets a SegwitP2SH Bitcoin MainNet Address
        /// </summary>
        /// <param name="publicKey">
        ///     The Bitcoin Public Key
        /// </param>
        /// <returns>
        ///     A SegwitP2SH Bitcoin Main Address
        /// </returns>
        public BitcoinAddress GetSegwitP2SHBitcoinMainNetAddress(PubKey publicKey)
        {
            BitcoinAddress segwitP2SHBitcoinMainNetAddress = publicKey.GetAddress(ScriptPubKeyType.SegwitP2SH, Network.Main);
            return segwitP2SHBitcoinMainNetAddress;
        }
        
    }
}
