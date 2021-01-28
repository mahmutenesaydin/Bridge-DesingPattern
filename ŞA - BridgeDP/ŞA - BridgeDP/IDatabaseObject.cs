using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ŞA___BridgeDP
{
    public interface IDatabaseObject<T>
    {
        void Add(T t);
        void Remove(T t);
        List<T> ShowAll();
        T Prior { get; }
        T Next { get; }
        T Last { get; }
        T First { get; }
        T Current { get; }
    }

    public class ShipperDatabaseObject : IDatabaseObject<Shipper>
    {
        private NorthwindEntities db = new NorthwindEntities();
        private List<Shipper> _shippers;
        private int _current = 0;

        public ShipperDatabaseObject()
        {
            _shippers = db.Shippers.ToList();
        }

        public Shipper Current
        {
            get
            {
                return _shippers[_current];
            }
        }

        public Shipper First
        {
            get
            {
                return _shippers[0];
            }
        }

        public Shipper Last
        {
            get
            {
                return _shippers[_shippers.Count - 1];
            }
        }

        public Shipper Next
        {
            get
            {
                if (_current < _shippers.Count - 1)
                    _current++;
                return _shippers[_current];
            }
        }

        public Shipper Prior
        {
            get
            {
                if (_current > 0)
                    _current--;
                return _shippers[_current];
            }
        }

        public void Add(Shipper t)
        {
            db.Shippers.Add(t);
            db.SaveChanges();
        }

        public void Remove(Shipper t)
        {
            db.Shippers.Remove(t);
            db.SaveChanges();
        }

        public List<Shipper> ShowAll()
        {
            return _shippers;
        }
    }

    public class ShipperBase
    {
        public IDatabaseObject<Shipper> DataObject { get; set; }
        public Shipper Prior { get { return DataObject.Prior; } }
        public Shipper Next { get { return DataObject.Next; } }
        public Shipper First { get { return DataObject.First; } }
        public Shipper Last { get { return DataObject.Last; } }
        public Shipper Current { get { return DataObject.Current; } }
        public void Add(Shipper shipper) { DataObject.Add(shipper); }
        public void Delete(Shipper shipper) { DataObject.Remove(shipper); }
        public List<Shipper> ShowAll() { return DataObject.ShowAll(); }
    }
}
