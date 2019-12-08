﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;

namespace BlockChainSharp.Core
{
    class Block
    {
        private readonly int index;
        private readonly DateTime timeStamp;
        private readonly string hash;
        private readonly string data;
        private readonly string previousHash;

        public string Data => data;
        public string Hash => hash;
        public int Index => index;
        public string PreviousHash => previousHash;

        public Block(int index, DateTime timeStamp, string data, string previousHash)
        {
            this.index = index;
            this.timeStamp = timeStamp;
            this.previousHash = previousHash;
            this.data = data;
            using (SHA256 sha256Hash = SHA256.Create())
            {
                hash = Hashier.GetHash(sha256Hash, data);
            }
        }
    }
}
