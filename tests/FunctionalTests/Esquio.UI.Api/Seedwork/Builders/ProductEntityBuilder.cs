﻿using Esquio.EntityFrameworkCore.Store.Entities;
using System.Collections.Generic;

namespace FunctionalTests.Esquio.UI.Api.Seedwork.Builders
{
    public class ProductEntityBuilder
    {
        private string _name;
        private List<FeatureEntity> _features = new List<FeatureEntity>();
        private List<RingEntity> _rings = new List<RingEntity>();

        public ProductEntityBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public ProductEntityBuilder WithFeature(FeatureEntity featureEntity)
        {
            _features.Add(featureEntity);
            return this;
        }

        public ProductEntityBuilder WithRing(RingEntity ringEntity)
        {
            _rings.Add(ringEntity);
            return this;
        }

        public ProductEntity Build()
        {
            var entity = new ProductEntity(_name);
            
            foreach(var item in _features)
            {
                entity.Features.Add(item);
            }

            foreach (var item in _rings)
            {
                entity.Rings.Add(item);
            }

            return entity;
        }
    }
}
