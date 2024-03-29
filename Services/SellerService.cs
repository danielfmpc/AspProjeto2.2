﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Teste2.Data;
using Teste2.Models;

namespace Teste2.Services
{
    public class SellerService
    {
        private readonly Teste2Context _context;

        public SellerService(Teste2Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
