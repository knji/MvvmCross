// <copyright file="MvxTouchViewDispatcherProvider.cs" company="Cirrious">
// (c) Copyright Cirrious. http://www.cirrious.com
// This source is subject to the Microsoft Public License (Ms-PL)
// Please see license.txt on http://opensource.org/licenses/ms-pl.html
// All other rights reserved.
// </copyright>
// 
// Project Lead - Stuart Lodge, Cirrious. http://www.cirrious.com

using Cirrious.MvvmCross.Interfaces.Views;
using Cirrious.MvvmCross.Mac.Interfaces;

namespace Cirrious.MvvmCross.Mac.Views
{
    public class MvxMacViewDispatcherProvider
        : IMvxViewDispatcherProvider
    {
        private readonly IMvxMacViewPresenter _presenter;

        public MvxMacViewDispatcherProvider(IMvxMacViewPresenter presenter)
        {
            _presenter = presenter;
        }

        public IMvxViewDispatcher ViewDispatcher
        {
            get { return new MvxMacViewDispatcher(_presenter); }
        }
    }
}