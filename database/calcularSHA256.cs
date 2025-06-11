﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WorkSync.database
{
	internal class calcularSHA256
	{
		public static string CalcularSHA256(string texto)
		{
			using (SHA256 sha256 = SHA256.Create())
			{
				byte[] bytes = Encoding.UTF8.GetBytes(texto);
				byte[] hash = sha256.ComputeHash(bytes);

				StringBuilder sb = new StringBuilder();
				foreach (byte b in hash)
					sb.Append(b.ToString("x2"));

				return sb.ToString();
			}
		}
	}
}
