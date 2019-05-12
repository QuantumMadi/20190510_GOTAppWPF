using GOT.Models;
using GOT.Service;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace GOT.WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Character> characters;
        public MainWindow()
        {
            InitializeComponent();
            characters = GetDataService.GetListOfCharacters();
            var characterName = characters.Select(c => c.Name);
            charactersList.ItemsSource = characterName;
        }

        private void DoubleClickLeftMouseButton(object sender, MouseButtonEventArgs e)
        {
            var selectedCharacterName = charactersList.SelectedItem.ToString();

            var selectedCharacter = characters.FirstOrDefault(c => c.Name == selectedCharacterName);

            CharacterWindow characterWindow = new CharacterWindow(selectedCharacter);
            characterWindow.ShowDialog();
        }

        private void FilterCharacter(object sender, TextChangedEventArgs e)
        {
            var charactersName = characters.Select(c => c.Name);
            var sortedCharacters = charactersName.Where(c => c.ToLower().Contains(characterNameTextBox.Text.ToLower()));

            charactersList.ItemsSource = sortedCharacters;
        }
    }
}
