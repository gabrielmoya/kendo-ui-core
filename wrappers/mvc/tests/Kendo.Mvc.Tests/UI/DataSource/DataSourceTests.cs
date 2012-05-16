﻿namespace Kendo.Mvc.Tests
{
    using Xunit;
    using Kendo.Mvc.UI;

    public class DataSourceTests
    {
        private DataSource dataSource;

        public DataSourceTests()
        {
            dataSource = new DataSource();
        }

        [Fact]
        public void ToJson_serverPaging_is_serialized_if_set()
        {
            dataSource.ServerPaging = true;

            var result = dataSource.ToJson();
            ((bool)result["serverPaging"]).ShouldBeTrue();
        }

        [Fact]
        public void ToJson_serverPaging_is_not_serialized_if_not_set()
        {
            var result = dataSource.ToJson();
            result.ContainsKey("serverPaging").ShouldBeFalse();
        }


        [Fact]
        public void ToJson_serverSorting_is_serialized_if_set()
        {
            dataSource.ServerSorting = true;

            var result = dataSource.ToJson();
            ((bool)result["serverSorting"]).ShouldBeTrue();
        }

        [Fact]
        public void ToJson_serverSorting_is_not_serialized_if_not_set()
        {
            var result = dataSource.ToJson();
            result.ContainsKey("serverSorting").ShouldBeFalse();
        }

        [Fact]
        public void ToJson_serverFiltering_is_serialized_if_set()
        {
            dataSource.ServerFiltering = true;

            var result = dataSource.ToJson();
            ((bool)result["serverFiltering"]).ShouldBeTrue();
        }

        [Fact]
        public void ToJson_serverFiltering_is_not_serialized_if_not_set()
        {
            var result = dataSource.ToJson();
            result.ContainsKey("serverFiltering").ShouldBeFalse();
        }

        [Fact]
        public void ToJson_serverGrouping_is_serialized_if_set()
        {
            dataSource.ServerGrouping = true;

            var result = dataSource.ToJson();
            ((bool)result["serverGrouping"]).ShouldBeTrue();
        }

        [Fact]
        public void ToJson_serverGrouping_is_not_serialized_if_not_set()
        {
            var result = dataSource.ToJson();
            result.ContainsKey("serverGrouping").ShouldBeFalse();
        }

        [Fact]
        public void ToJson_serverAggregates_is_serialized_if_set()
        {
            dataSource.ServerAggregates = true;

            var result = dataSource.ToJson();
            ((bool)result["serverAggregates"]).ShouldBeTrue();
        }

        [Fact]
        public void ToJson_serverAggregates_is_not_serialized_if_not_set()
        {
            var result = dataSource.ToJson();
            result.ContainsKey("serverAggregates").ShouldBeFalse();
        }

        [Fact]
        public void ToJson_pageSize_is_serialized()
        {
            dataSource.PageSize = 42;
            var result = dataSource.ToJson();
            result["pageSize"].ShouldEqual(42);
        }

        [Fact]
        public void ToJson_pageSize_is_not_serialized_if_not_set()
        {            
            var result = dataSource.ToJson();
            result.ContainsKey("serverAggregates").ShouldBeFalse();
        }
    }
}