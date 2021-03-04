using System;

namespace RoutingDemo
{
    #region Action Dependencies
    
    public class BitcoinStore
    {
    }

    public class WalletManagerViewModel
    {
    }

    public class Network
    {
    }

    public class WalletManager
    {
    }

    #endregion

    #region Attributes

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ActionAttribute : Attribute
    {
        public string Route { get; set; }

        public ActionAttribute(string route)
        {
            Route = route;
        }
    }
    
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class ControllerAttribute : Attribute
    {
        public string Route { get; set; }

        public ControllerAttribute(string route)
        {
            Route = route;
        }
    }

    #endregion

    [Controller("/AddWallet")] // AddWalletPageViewModel
    public class AddWalletController
    {
        public WalletManagerViewModel WalletManagerViewModel { get; set; }
        public BitcoinStore Store { get; set; }
    }

    [Action("/AddWallet/RecoverWallet")] // AddWalletPageViewModel.RecoverWalletCommand
    public class RecoverWalletAction // RecoverWalletViewModel
    {
        public RecoverWalletAction(string walletName, WalletManagerViewModel walletManagerViewModel)
        {
        }
    }

    [Action("/AddWallet/CreateWallet")] // AddWalletPageViewModel.CreateWalletCommand
    public class CreateWalletAction // CreatePasswordDialogViewModel > RecoveryWordsViewModel
    {
        public CreateWalletAction(WalletManager walletManager, BitcoinStore store, Network network)
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}