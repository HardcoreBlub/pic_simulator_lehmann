﻿namespace pic__simulator__lehmann.Models
{
    public abstract class Speicher
    {
        
        public int[] _speicher;
        protected int _size;

        public Speicher(int size)
        {
            _speicher = new int[size];
            _speicher.Initialize();
            _size = size;
        }

        public int Read(int index)
        {
            if (index > _size)
            {
                throw new OverflowException("Programmspeicher Ende erreicht");
            }
            return _speicher[index];
        }
        
    }
}
