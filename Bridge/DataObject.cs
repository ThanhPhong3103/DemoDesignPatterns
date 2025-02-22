﻿using System;

namespace Bridge.RealWorld
{
    /// <summary>
    /// The 'Implementor' abstract class
    /// </summary>
    public abstract class DataObject
    {
        public abstract void NextRecord();
        public abstract void PriorRecord();
        public abstract void AddRecord(string name);
        public abstract void DeleteRecord(string name);
        public abstract string GetCurrentRecord();
        public abstract void ShowRecord();
        public abstract void ShowAllRecords();
    }
}
