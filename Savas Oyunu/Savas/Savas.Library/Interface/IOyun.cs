﻿using Savas.Library.Enum;
using System;
//using System.Dynamic;

namespace Savas.Library.Interface
{
    internal interface IOyun

    {
        event EventHandler GecenSureDegisti;
        bool DevamEdiyorMu { get; }
        TimeSpan GecenSure { get; }
        void Baslat();
        void AtesEt();

        void UcaksavariHareketEttir(Yon yon);


    }
}
