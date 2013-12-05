using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dac.Model;

namespace Public.Dac.Samples
{
    public static class TSqlModelExtensions
    {
        /// <summary>
        /// Copies the <see cref="DatabaseOptions"/> for the model to a <see cref="TSqlModelOptions"/> object.
        /// This is useful if you wish to duplicate the options for a model when creating a new model.
        /// Note that this method may be included in the public model framework in the future.
        /// </summary>
        public static TSqlModelOptions CloneModelOptions(this TSqlModel model)
        {
            TSqlModelOptions clonedOptions = new TSqlModelOptions();
            TSqlObject options = model.GetObjects(DacQueryScopes.All, DatabaseOptions.TypeClass).FirstOrDefault();
            if (options == null)
            {
                return clonedOptions;
            }

            clonedOptions.Collation = options.GetProperty<string>(DatabaseOptions.Collation);
            clonedOptions.AllowSnapshotIsolation = options.GetProperty<bool>(DatabaseOptions.AllowSnapshotIsolation);
            clonedOptions.TransactionIsolationReadCommittedSnapshot = options.GetProperty<bool>(DatabaseOptions.TransactionIsolationReadCommittedSnapshot);
            clonedOptions.AnsiNullDefaultOn = options.GetProperty<bool>(DatabaseOptions.AnsiNullDefaultOn);
            clonedOptions.AnsiNullsOn = options.GetProperty<bool>(DatabaseOptions.AnsiNullsOn);
            clonedOptions.AnsiPaddingOn = options.GetProperty<bool>(DatabaseOptions.AnsiPaddingOn);
            clonedOptions.AnsiWarningsOn = options.GetProperty<bool>(DatabaseOptions.AnsiWarningsOn);
            clonedOptions.ArithAbortOn = options.GetProperty<bool>(DatabaseOptions.ArithAbortOn);
            clonedOptions.AutoClose = options.GetProperty<bool>(DatabaseOptions.AutoClose);
            clonedOptions.AutoCreateStatistics = options.GetProperty<bool>(DatabaseOptions.AutoCreateStatistics);
            clonedOptions.AutoShrink = options.GetProperty<bool>(DatabaseOptions.AutoShrink);
            clonedOptions.AutoUpdateStatistics = options.GetProperty<bool>(DatabaseOptions.AutoUpdateStatistics);
            clonedOptions.AutoUpdateStatisticsAsync = options.GetProperty<bool>(DatabaseOptions.AutoUpdateStatisticsAsync);
            clonedOptions.ChangeTrackingAutoCleanup = options.GetProperty<bool>(DatabaseOptions.ChangeTrackingAutoCleanup);
            clonedOptions.ChangeTrackingEnabled = options.GetProperty<bool>(DatabaseOptions.ChangeTrackingEnabled);
            clonedOptions.ChangeTrackingRetentionPeriod = options.GetProperty<int>(DatabaseOptions.ChangeTrackingRetentionPeriod);
            clonedOptions.ChangeTrackingRetentionUnit = options.GetProperty<TimeUnit>(DatabaseOptions.ChangeTrackingRetentionUnit);
            clonedOptions.CompatibilityLevel = options.GetProperty<int>(DatabaseOptions.CompatibilityLevel);
            clonedOptions.ConcatNullYieldsNull = options.GetProperty<bool>(DatabaseOptions.ConcatNullYieldsNull);
            clonedOptions.Containment = options.GetProperty<Containment>(DatabaseOptions.Containment);
            clonedOptions.CursorCloseOnCommit = options.GetProperty<bool>(DatabaseOptions.CursorCloseOnCommit);
            clonedOptions.CursorDefaultGlobalScope = options.GetProperty<bool>(DatabaseOptions.CursorDefaultGlobalScope);
            clonedOptions.DatabaseStateOffline = options.GetProperty<bool>(DatabaseOptions.DatabaseStateOffline);
            clonedOptions.DateCorrelationOptimizationOn = options.GetProperty<bool>(DatabaseOptions.DateCorrelationOptimizationOn);
            clonedOptions.DefaultFullTextLanguage = options.GetProperty<string>(DatabaseOptions.DefaultFullTextLanguage);
            clonedOptions.DefaultLanguage = options.GetProperty<string>(DatabaseOptions.DefaultLanguage);
            clonedOptions.DBChainingOn = options.GetProperty<bool>(DatabaseOptions.DBChainingOn);
            clonedOptions.FileStreamDirectoryName = options.GetProperty<string>(DatabaseOptions.FileStreamDirectoryName);
            clonedOptions.FullTextEnabled = options.GetProperty<bool>(DatabaseOptions.FullTextEnabled);
            clonedOptions.HonorBrokerPriority = options.GetProperty<bool>(DatabaseOptions.HonorBrokerPriority);
            clonedOptions.NestedTriggersOn = options.GetProperty<bool>(DatabaseOptions.NestedTriggersOn);
            clonedOptions.NonTransactedFileStreamAccess = options.GetProperty<NonTransactedFileStreamAccess>(DatabaseOptions.NonTransactedFileStreamAccess);
            clonedOptions.NumericRoundAbortOn = options.GetProperty<bool>(DatabaseOptions.NumericRoundAbortOn);
            clonedOptions.PageVerifyMode = options.GetProperty<PageVerifyMode>(DatabaseOptions.PageVerifyMode);
            clonedOptions.ParameterizationOption = options.GetProperty<ParameterizationOption>(DatabaseOptions.ParameterizationOption);
            clonedOptions.QuotedIdentifierOn = options.GetProperty<bool>(DatabaseOptions.QuotedIdentifierOn);
            clonedOptions.ReadOnly = options.GetProperty<bool>(DatabaseOptions.ReadOnly);
            clonedOptions.RecoveryMode = options.GetProperty<RecoveryMode>(DatabaseOptions.RecoveryMode);
            clonedOptions.RecursiveTriggersOn = options.GetProperty<bool>(DatabaseOptions.RecursiveTriggersOn);
            clonedOptions.ServiceBrokerOption = options.GetProperty<ServiceBrokerOption>(DatabaseOptions.ServiceBrokerOption);
            clonedOptions.SupplementalLoggingOn = options.GetProperty<bool>(DatabaseOptions.SupplementalLoggingOn);
            clonedOptions.TargetRecoveryTimePeriod = options.GetProperty<int>(DatabaseOptions.TargetRecoveryTimePeriod);
            clonedOptions.TargetRecoveryTimeUnit = options.GetProperty<TimeUnit>(DatabaseOptions.TargetRecoveryTimeUnit);
            clonedOptions.TornPageProtectionOn = options.GetProperty<bool>(DatabaseOptions.TornPageProtectionOn);
            clonedOptions.TransformNoiseWords = options.GetProperty<bool>(DatabaseOptions.TransformNoiseWords);
            clonedOptions.Trustworthy = options.GetProperty<bool>(DatabaseOptions.Trustworthy);
            clonedOptions.TwoDigitYearCutoff = options.GetProperty<short>(DatabaseOptions.TwoDigitYearCutoff);
            clonedOptions.VardecimalStorageFormatOn = options.GetProperty<bool>(DatabaseOptions.VardecimalStorageFormatOn);
            clonedOptions.UserAccessOption = options.GetProperty<UserAccessOption>(DatabaseOptions.UserAccessOption);
            clonedOptions.WithEncryption = options.GetProperty<bool>(DatabaseOptions.WithEncryption);

            return clonedOptions;
        }

    }
}
