﻿using System;

namespace SubSync
{

    public interface IStatusResultReporter<TReportResult> : IStatusReporter
    {
        event EventHandler<TReportResult> OnReportFinished;
    }
    
    public interface IStatusReporter<in TReportData>  : IStatusReporter
    {        
        void Report(TReportData data);        
    }

    public interface IStatusReporter
    {
        void FinishReport();
    }
}