using App2.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TSViewerPage : ContentPage
    {
        public ObservableCollection<TSItems> timesheets { get; set; }

        public TSViewerPage()
        {
            timesheets = new ObservableCollection<TSItems>();
            ListView lstView = new ListView();
            lstView.RowHeight = 60;
            this.Title = "Timesheets list";

            lstView.ItemTemplate = new DataTemplate(typeof(CustomTimeSheets));
            timesheets.Add(new TSItems { Status = 1, Description = "studio", Hours = 8 });
            timesheets.Add(new TSItems { Status = 1, Description = "studio", Hours = 8 });
            timesheets.Add(new TSItems { Status = 1, Description = "studio", Hours = 8 });
            lstView.ItemsSource = timesheets;

            Content = lstView;
        }

        public class CustomTimeSheets : ViewCell

        {
            public CustomTimeSheets()

            {//instantiate each of our views

                var date = new Label();
                var hours = new Label();
                var description = new Label();
                var status = new Label();
                var verticalLayout = new StackLayout() { BackgroundColor = Color.White };
                var horizontalLayout = new StackLayout() { BackgroundColor = Color.Red };
                
                //set bindings

                date.SetBinding(Label.TextProperty, new Binding("Date"));
                hours.SetBinding(Label.TextProperty, new Binding("Hours"));
                description.SetBinding(Label.TextProperty, new Binding("Description"));
                status.SetBinding(Label.TextProperty, new Binding("Status"));

                //Set properties for desired design

                horizontalLayout.Orientation = StackOrientation.Horizontal;
                horizontalLayout.HorizontalOptions = LayoutOptions.Fill;

                //add views to the view hierarchy

                horizontalLayout.Children.Add(date);
                horizontalLayout.Children.Add(hours);
                horizontalLayout.Children.Add(description);
                horizontalLayout.Children.Add(status);
                verticalLayout.Children.Add(horizontalLayout);

                // add to parent view

                View = verticalLayout;

            }

        }
    }
}