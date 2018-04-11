using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGisBLL
{
    public class Map: IMap
    {
        private string _name = string.Empty;
        private List<ILayer> _layers = new List<ILayer>();
        private Dictionary<string, ILayer> _dictionary = new Dictionary<string, ILayer>();
        string IMap.Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        
        List<ILayer> IMap.Layers
        {
            get
            {
                return _layers;
            }
        }

        int IMap.LayerCount
        {
            get
            {
                return _layers.Count;
            }
        }

        void IMap.AddLayer(ILayer layer)
        {
            
            _layers.Add(layer);
            _dictionary.Add(layer.Name, layer);
        }

        void IMap.RemoveLayer(int index)
        {
            _layers.Remove(_layers[index]);
            _dictionary.Remove(_layers[index].Name);
        }

        ILayer IMap.GetLayer(string layerName)
        {
            if (_dictionary[layerName] != null)
                return _dictionary[layerName];
            else
                return null;
        }
    }
}
