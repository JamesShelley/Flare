using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BitcoinBlazor.Data.DataModels;
using NBitcoin;

namespace BitcoinBlazor.Services
{
    public interface IBitcoinService
    {
        //Add a bitcoin address to database
        Task<UserBitcoinAddress> Add(UserBitcoinAddress bitcoinAddress);

        //Edit a bitcoin address nickname
        Task<UserBitcoinAddress> Update(UserBitcoinAddress bitcoinAddress);

        //Delete a bitcoin address
        Task<UserBitcoinAddress> Delete(int id);

        //Generates a Bitcoin Private Key
        Key GeneratePrivateKey();
        
        //List Bitcoin Addresses
        Task<List<UserBitcoinAddress>> GetAddresses();

        //Generates Public Key from private key
        PubKey GeneratePublicKey(Key privateKey);

        //Get Legacy Bitcoin TestNet address from Public Key
        BitcoinAddress GetLegacyBitcoinTestNetAddress(PubKey publicKey);

        //Get Legacy Bitcoin MainNet address from Public Key
        BitcoinAddress GetLegacyBitcoinMainNetAddress(PubKey publicKey);

        //Get Segwit Bitcoin MainNet address from Public Key
        BitcoinAddress GetSegwitBitcoinTestNetAddress(PubKey publicKey);

        //Get Segwit Bitcoin MainNet address from Public Key
        BitcoinAddress GetSegwitBitcoinMainNetAddress(PubKey publicKey);

        //Get SegwitP2SH Bitcoin TestNet address from Public Key
        BitcoinAddress GetSegwitP2SHBitcoinTestNetAddress(PubKey publicKey);

        //Get SegwitP2SH Bitcoin MainNet address from Public Key
        BitcoinAddress GetSegwitP2SHBitcoinMainNetAddress(PubKey publicKey);

    }
}
