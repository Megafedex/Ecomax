﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ecomax
{
    class ModoPagoControlador : Controlador
    {
        public bool IsNumber(string num) {
            int referencia = 0;
            long referencia2 = 0;
            if (int.TryParse(num,out referencia)){
                return true;
            }
            else if (long.TryParse(num, out referencia2))
            {
                return true;
            }
            return false;
        }

        public bool InNumber(int num) {
            if (num > 0 && num <= 3) {
                return true;
            }
            return false;
        }
    }
}
