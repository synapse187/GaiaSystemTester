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
            this.SimSettings = new SimSettings();
            this.SelectedCharacter = new SelectedCharacter();
            this.CharacterSheets = new ObservableCollection<CharacterSheet>();
            this.SkillList = new Skills.SkillList();
            this.SkilledStats = new ActionStatsSelectedSkill();
            CharacterSheets.Add(new CharacterSheet("Fulkan"));
            CharacterSheets[0].NameOfCurrentSkill = "Un-skilled";
            CharactersListView.SelectedIndex = 0;
            SkillSelect_ListBox.SelectedIndex = 0;
            }
        private CharacterSheet BaseSheet{ get; set; }
        public ActionStatsSelectedSkill SkilledStats { get; set; }
        public Skills.SkillList SkillList { get; }
        public ObservableCollection<CharacterSheet> CharacterSheets { get; set; }
        public SimSettings SimSettings { get; set; }
        public SelectedCharacter SelectedCharacter { get; set; }

        private void StatsSelectToggleSwitch_Toggled(Object sender, RoutedEventArgs e)
            {
            ToggleSwitch toggleSwitch = (ToggleSwitch)sender;
            if(toggleSwitch.IsOn)
                {
                P1StandardStatsPanel.Visibility = Visibility.Visible;
                QuickStatsPanel.Visibility = Visibility.Collapsed;
                }
            if(!toggleSwitch.IsOn)
                {
                P1StandardStatsPanel.Visibility = Visibility.Collapsed;
                QuickStatsPanel.Visibility = Visibility.Visible;
                }

            }
            
        private void RunSim(object sender, RoutedEventArgs e)
            {
            if(CharacterSheets.Count()==0)
                {
                TextBoxOutputWindow.Text += "Please Create a Character to run simulation.";
                }
            else if(CharacterSheets.Count()<2 && SimSettings.SimulationType > 0)
                {
                TextBoxOutputWindow.Text += "Please Create 2 Characters to run simulation.";
                }
            Sim.DiceRoller diceRoller = new Sim.DiceRoller(CharacterSheets, SimSettings, textBoxOutputWindow: ref TextBoxOutputWindow);
            diceRoller.RunSimulation();
            }

        private void ClearWindowButton_Click(object sender, RoutedEventArgs e)
            {
            TextBoxOutputWindow.Text = "";
            }

        private void AddCharacter(object sender, RoutedEventArgs e)
            {
            string name = CharacterToAddNameTextBox.Text;
            CharacterSheet character = new CharacterSheet(name);
            character.RefreshStats();
            CharacterSheets.Add(character);
            }

        private void CharactersListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
            ListView view = (ListView)sender;
            if(view.SelectedIndex >= 0 && view.SelectedIndex <= CharacterSheets.Count)
                {
                SelectedCharacter.CurentCharacter = CharacterSheets[view.SelectedIndex];
                PlayerStatsPannelContentControl.IsEnabled = true;
                }
            else if(CharacterSheets.Count == 0)
                {
                SelectedCharacter.CurentCharacter = null;
                PlayerStatsPannelContentControl.IsEnabled = false;
                }
            else
                {
                SelectedCharacter.CurentCharacter = CharacterSheets[0];
                PlayerStatsPannelContentControl.IsEnabled = true;
                }
            }

        private void Reset_Character_Button_Click(object sender, RoutedEventArgs e)
        {
            SelectedCharacter.CurentCharacter.DefaultStats();
        }

        private void Remove_Character_Button_Click(object sender, RoutedEventArgs e)
            {
            if(CharacterSheets.Count == 1 || CharactersListView.SelectedIndex <= 0)
                {
                CharacterSheets.RemoveAt(CharactersListView.SelectedIndex);
                SelectedCharacter.CurentCharacter = null;
                PlayerStatsPannelContentControl.IsEnabled = false;
                }
            else if(CharacterSheets.Count > 1 && CharactersListView.SelectedIndex <= 0)
                {
                CharacterSheets.RemoveAt(CharactersListView.SelectedIndex);
                SelectedCharacter.CurentCharacter = CharacterSheets[0];
                PlayerStatsPannelContentControl.IsEnabled = true;
                }
            else
                {
                SelectedCharacter.CurentCharacter = null;
                PlayerStatsPannelContentControl.IsEnabled = false;
                }
            }

        private void AddSkill_Button_Click(object sender, RoutedEventArgs e)
            {
            AddSkill_PopUp.IsOpen = !AddSkill_PopUp.IsOpen;
            }

        private void SkillSelect_ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
            ListBox listBox = (ListBox)sender;
            int index = listBox.SelectedIndex;
            if(index > -1)
                {
                SelectedCharacter.CurentCharacter.Skills.AddSkill(SkillList.SkillSelectionList[index]);
                }
            if(AddSkill_PopUp.IsOpen)
                {
                AddSkill_PopUp.IsOpen = false;
                };
            }

        private void CharactersSkillsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
            {
            ListView listView = (ListView)sender;
            int index = listView.SelectedIndex;
            if(index > -1)
                {
                SelectedCharacter.CurentCharacter.SkillModList = SelectedCharacter.CurentCharacter.Skills.SkillList[index].ModList;
                SelectedCharacter.CurentCharacter.NameOfCurrentSkill = SelectedCharacter.CurentCharacter.Skills.SkillList[index].Name;
                SelectedCharacter.CurentCharacter.RefreshStats();
                }
            }

        private void AttributeValue_NumberBox_ValueChanged(MUXC.NumberBox sender, MUXC.NumberBoxValueChangedEventArgs args)
            {
            SelectedCharacter.CurentCharacter.RefreshStats();
            }

        private void SkillRank_NumberBox_ValueChanged(MUXC.NumberBox sender, MUXC.NumberBoxValueChangedEventArgs args)
            {
            SelectedCharacter.CurentCharacter.RefreshStats();
            }
        }
    }
