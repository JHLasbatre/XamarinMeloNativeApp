using System;
using System.Diagnostics;
using System.Threading.Tasks;
using XamarinMeloNativeApp.Helpers;
using XamarinMeloNativeApp.Model;

#if __IOS__
using XamarinMeloNativeApp.iOS;
#elif __ANDROID__
using XamarinMeloNativeApp.Droid;
#else
using XamarinMeloNativeApp.UWP.Views;
#endif

namespace XamarinMeloNativeApp.ViewModel
{
    public class ItemsViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Item> Items { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableRangeCollection<Item>();
            var task = ExecuteLoadItemsCommand();
            task.Wait();

#if __IOS__
            MessagingCenter.Subscribe<ItemNewViewController, Item>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Item;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
#elif __ANDROID__
            MessagingCenter.Subscribe<Android.App.Activity, Item>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Item;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
#else
            MessagingCenter.Subscribe<AddItems, Item>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as Item;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
#endif

        }

        public async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                Items.ReplaceRange(items);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
               // MessageDialog.SendMessage("Unable to load items.", "Error");
            }
            finally
            {
                IsBusy = false;
            }
        }


        //public Command<string> GoToDetailsCommand { get; }
        ItemDetailViewModel detailsViewModel;

    }
}