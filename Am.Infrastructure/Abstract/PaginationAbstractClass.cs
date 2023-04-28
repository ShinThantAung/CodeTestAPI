﻿namespace Am.Infrastructure.Abstract
{
    public abstract class PaginationAbstractClass
    {
        const int maxPageSize = 50;
        private int _pageNumber = 1;
        public int PageNumber
        {
            get { return _pageNumber; }
            set { _pageNumber = value < _pageNumber ? _pageNumber : value; }
        }
        private int _pageSize = 10;
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = (value > maxPageSize) ? maxPageSize : value;
            }
        }
    }
}
