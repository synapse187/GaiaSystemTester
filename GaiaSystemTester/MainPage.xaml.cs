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
            this.SelectedCharacter = new SelectedCharacter();
            this.CharacterSheets = new ObservableCollection<CharacterSheet>();
            CharacterSheets.Add(new CharacterSheet("Fulkan"));
            }
        public IList<CharacterSheet> CharacterSheets { get; set; }
        public CharacterSheet CharSheet { get; set; }
        public SimSettings SimSettings { get; set; }
        public int CharacterIndexToGet = 0;
        public SelectedCharacter SelectedCharacter { get; set; }



        private void NumberBoxValueChanged(MUXC.NumberBox sender, MUXC.NumberBoxValueChangedEventArgs args)
            {
            //if(CharSheet != null)
            //    {
            //    string outString;
            //    outString = $"{sender.Tag.ToString()}:  {sender.Value}\n";
            //    TextBoxOutputWindow.Text += outString;
            //    }
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
            //TextBoxOutputWindow.Text += CharacterSheets[0].CharStatsQuick.Health.ToString();
            }

        private void RunSim(object sender, RoutedEventArgs e)
            {
            //DiceRoller diceRoller = new DiceRoller(CharacterSheets.ToList<CharacterSheet>, SimSettings, ref TextBoxOutputWindow);
            //diceRoller.RunSimulation();
            }

        private void Button_Click(object sender, RoutedEventArgs e)
            {
            foreach(CharacterSheet item in CharacterSheets)
                {
                TextBoxOutputWindow.Text += $"Char: {item.CharBio.Name}\n";
                TextBoxOutputWindow.Text += $"Health: {item.CharStatsQuick.Health}-Endurance: {item.CharStatsQuick.Endurance}\n";
                }
            TextBoxOutputWindow.Text += SelectedCharacter.CurentCharacter.CharBio.Name;
            }

        private void AddCharacter(object sender, RoutedEventArgs e)
            {
            string name = CharacterToAddNameTextBox.Text;
            CharacterSheets.Add(new CharacterSheet(name));
            CharactersListView.ItemsSource = CharacterSheets;
            }

        private void CharactersListView_ItemClick(object sender, SelectionChangedEventArgs e)
            {
            ListView view = (ListView)sender;
            SelectedCharacter.CurentCharacter = CharacterSheets[view.SelectedIndex];
            TextBoxOutputWindow.Text += $"SelectedCharacter IS: {SelectedCharacter.CurentCharacter.CharBio.Name}\n";
            }
        }
    }
