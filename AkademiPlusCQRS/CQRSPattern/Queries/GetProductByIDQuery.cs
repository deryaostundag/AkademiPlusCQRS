﻿namespace AkademiPlusCQRS.CQRSPattern.Queries
{
    public class GetProductByIDQuery
    {
        public GetProductByIDQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
