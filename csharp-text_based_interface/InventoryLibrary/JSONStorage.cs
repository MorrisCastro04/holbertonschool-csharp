using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    public class JSONStorage
    {
        private Dictionary<string, object> objects = new Dictionary<string, object>();

        private readonly string filePath = Path.Combine("storage", "inventory_manager.json");

        public Dictionary<string, object> All()
        {
            return objects;
        }

        public void New(object obj)
        {
            string key = obj.GetType().Name + "." + ((BaseClass)obj).id;
            objects.Add(key, obj);
        }

        public void Save()
        {
            Directory.CreateDirectory("storage");

            string json = JsonSerializer.Serialize(objects, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.WriteAllText(filePath, json);
        }

        public void Load()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                if (json.Length > 0)
                {
                    objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json);
                }
                else
                {
                    objects = new Dictionary<string, object>();
                }
            }
            else
            {
                objects = new Dictionary<string, object>();
            }
        }
    }
}