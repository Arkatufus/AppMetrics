﻿// <copyright file="IMetricContextRegistry.cs" company="App Metrics Contributors">
// Copyright (c) App Metrics Contributors. All rights reserved.
// </copyright>

using System;
using App.Metrics.Apdex;
using App.Metrics.BucketHistogram;
using App.Metrics.BucketTimer;
using App.Metrics.Counter;
using App.Metrics.Gauge;
using App.Metrics.Histogram;
using App.Metrics.Meter;
using App.Metrics.Timer;

namespace App.Metrics.Registry
{
    public interface IMetricContextRegistry
    {
        string Context { get; }

        IMetricRegistryManager DataProvider { get; }

        IApdex Apdex<T>(ApdexOptions options, Func<T> builder)
            where T : IApdexMetric;

        IApdex Apdex<T>(ApdexOptions options, MetricTags tags, Func<T> builder)
            where T : IApdexMetric;

        void ClearAllMetrics();

        ICounter Counter<T>(CounterOptions options, Func<T> builder)
            where T : ICounterMetric;

        ICounter Counter<T>(CounterOptions options, MetricTags tags, Func<T> builder)
            where T : ICounterMetric;

        IGauge Gauge<T>(GaugeOptions options, Func<T> builder)
            where T : IGaugeMetric;

        IGauge Gauge<T>(GaugeOptions options, MetricTags tags, Func<T> builder)
            where T : IGaugeMetric;

        IHistogram Histogram<T>(HistogramOptions options, Func<T> builder)
            where T : IHistogramMetric;

        IHistogram Histogram<T>(HistogramOptions options, MetricTags tags, Func<T> builder)
            where T : IHistogramMetric;

        IBucketHistogram BucketHistogram<T>(BucketHistogramOptions options, Func<T> builder)
            where T : IBucketHistogramMetric;

        IBucketHistogram BucketHistogram<T>(BucketHistogramOptions options, MetricTags tags, Func<T> builder)
            where T : IBucketHistogramMetric;

        IMeter Meter<T>(MeterOptions options, Func<T> builder)
            where T : IMeterMetric;

        IMeter Meter<T>(MeterOptions options, MetricTags tags, Func<T> builder)
            where T : IMeterMetric;

        ITimer Timer<T>(TimerOptions options, Func<T> builder)
            where T : ITimerMetric;

        ITimer Timer<T>(TimerOptions options, MetricTags tags, Func<T> builder)
            where T : ITimerMetric;

        ITimer BucketTimer<T>(BucketTimerOptions options, Func<T> builder)
            where T : IBucketTimerMetric;

        ITimer BucketTimer<T>(BucketTimerOptions options, MetricTags tags, Func<T> builder)
            where T : IBucketTimerMetric;
    }
}