using System;
using Newtonsoft.Json;
using System.Windows.Forms;
using System.IO;

namespace OOP
{
    public class SerializeDeserialize
    {
        readonly JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.Auto, Formatting = Formatting.Indented };
        private SaveFileDialog save = new SaveFileDialog();
        private OpenFileDialog open = new OpenFileDialog();

        public Undo Deserialize()
        {
            Undo undo = new Undo();
            try
            {
                open.ShowDialog();
                string str = open.FileName;

                using FileStream file = File.OpenRead(str);
                string reader = new StreamReader(file).ReadToEnd();

                undo = JsonConvert.DeserializeObject<Undo>(reader, settings);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return undo;
        }

        public void Serialize(Undo undo)
        {
            JsonSerializer serialize = JsonSerializer.Create(settings);
            try
            {
                save.DefaultExt = ".json";
                save.Filter = "JSON files (*.json)|*json|Text files (*.txt)|*txt";
                save.ShowDialog();

                string str = save.FileName;
                using StreamWriter SWriter = new StreamWriter(str);
                using JsonWriter JWriter = new JsonTextWriter(SWriter);

                serialize.Serialize(JWriter, undo);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
