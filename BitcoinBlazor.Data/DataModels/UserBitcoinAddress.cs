using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BitcoinBlazor.Data.DataModels
{
    public class UserBitcoinAddress
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        [Required(ErrorMessage="Address Nickname is Required")]
        public string AddressNickname { get; set; }
        public string BitcoinPublicKey { get; set; }
        public string LegacyBitcoinTestNetAddress { get; set; }
        public string LegacyBitcoinMainNetAddress { get; set; }
        public string SegWitBitcoinTestNetAddress { get; set; }
        public string SegWitBitcoinMainNetAddress { get; set; }
        public string SegWitP2SHBitcoinTestNetAddress { get; set; }
        public string SegWitP2SHBitcoinMainNetAddress { get; set; }



    }
}
