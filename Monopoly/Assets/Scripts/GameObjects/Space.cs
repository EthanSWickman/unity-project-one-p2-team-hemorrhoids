﻿namespace GameObjects{
    public class Space{
        private string _spaceName;
        private int _typeOfSpace;

        public string SpaceName
        {
            get => _spaceName;
            set => _spaceName = value;
        }

        public int TypeOfSpace
        {
            get => _typeOfSpace;
            set => _typeOfSpace = value;
        }
    }
}
