using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Collections.ObjectModel;
using MUXC = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GaiaSystemTester
    {
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
        {
        public MainPage()
            {
            this.InitializeComponent();
            this.CharSheet = new CharacterSheet();
            this.SimSettings = new SimSettings();
            Globals.AddCharacterSheet();
            //Globals.AddCharacterSheet();
            }
        public ObservableCollection<CharacterSheet> CharacterSheets { get; set; } = Globals.GlobalSheets;
        public CharacterSheet CharSheet { get; set; }
        public SimSettings SimSettings { get; set; }
        public int IndexToGet { get; set; }
        public CharacterSheet SelectedCharacter
        {
            get {
                return CharacterSheets[IndexToGet];
            }
            set
                {
                if(CharacterSheets[IndexToGet] != value)
                    {
                    CharacterSheets[IndexToGet] = value;
                    }
                }
        }
        private void NumberBoxValueChanged(MUXC.NumberBox sender, MUXC.NumberBoxValueChangedEventArgs args)
            {
            if(CharSheet != null)
                {
                string outString;
                outString = $"{sender.Tag.ToString()}:  {sender.Value}\n";
                TextBoxOutputWindow.Text += outString;
                }
            }

        private void StatsSelectToggleSwitch_Toggled(Object sender, RoutedEventArgs e)
            {
            ToggleSwitch toggleSwitch = (ToggleSwitch)sender;
            if(toggleSwitch.IsOn)
                {
                P1StandardStatsPanel.Visibility = Visibility.Visible;
                P1QuickStatsPanel.Visibility = Visibility.Collapsed;
                }
            if(!toggleSwitch.IsOn)
                {
                P1StandardStatsPanel.Visibility = Visibility.Collapsed;
                P1QuickStatsPanel.Visibility = Visibility.Visible;
                }

            }
            
        private void ValueChanged(MUXC.NumberBox sender, MUXC.NumberBoxValueChangedEventArgs args)
            {
            TextBoxOutputWindow.Text += CharacterSheets[0].CharStatsQuick.Health.ToString();
            }

        private void RunSim(object sender, RoutedEventArgs e)
            {
            //DiceRoller diceRoller = new DiceRoller(CharacterSheets.ToList<CharacterSheet>, SimSettings, ref TextBoxOutputWindow);
            //diceRoller.RunSimulation();
            }

        private void Button_Click(object sender, RoutedEventArgs e)
            {
            TextBox box = TextBoxOutputWindow;
            box.Text += ($"Health: {CharacterSheets[0].CharStatsQuick.Health.ToString()}");
            box.Text += ($"Endurance: {CharacterSheets[0].CharStatsQuick.Endurance.ToString()}");
            box.Text += ($"Pool: {CharacterSheets[0].CharStatsQuick.Pool.ToString()}");
            box.Text += ($"Target: {CharacterSheets[0].CharStatsQuick.Target.ToString()}");
            box.Text += ($"Accuracy: {CharacterSheets[0].CharStatsQuick.Accuracy.ToString()}");
            box.Text += ($"Damage: {CharacterSheets[0].CharStatsQuick.Damage.ToString()}");
            }

        private void AddCharacter(object sender, RoutedEventArgs e)
            {
            string name = CharacterToAddNameTextBox.Text;
            CharacterSheets.Add(new CharacterSheet(name));
            CharactersListView.ItemsSource = CharacterSheets;
            }

        private void CharactersListView_ItemClick(object sender, SelectionChangedEventArgs e)
            {
            ListView listView = (ListView)sender;
            if(listView.SelectedIndex > 0)
                {
                Binding binding = new Binding();
                IndexToGet = listView.SelectedIndex;
                binding.Source = SelectedCharacter.StatsToUse;
                P1StatsSelectToggleSwitch.IsOn = SelectedCharacter.StatsToUse;
                P1StatsSelectToggleSwitch.SetBinding(ToggleSwitch.IsOnProperty, binding);
                }
            TextBoxOutputWindow.Text += "Current Selected Index: " + listView.SelectedIndex + "\n";
            outputToWindow();
            }
        private void outputToWindow()
        {
            foreach(CharacterSheet sheet in CharacterSheets)
                {
                TextBoxOutputWindow.Text += $"{sheet.CharBio.Name}'s StatsToUse: {sheet.StatsToUse}\n";
                }
        }
        }
    }
