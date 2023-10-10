using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace
namespace DarkDynamics.Andromeda.Extensions.Runtime
{
    public static class TaskExtensions
    {
        public static async Task<IEnumerable<T>> WhenAll<T>(this IEnumerable<Task<T>> tasks)
        {
            Task<T[]> t = Task.WhenAll(tasks);
           
            try
            {
                return await t;
            }
            catch (Exception e)
            {
                //ignore
            }
        
            if(t.Status != TaskStatus.Canceled)
                throw t.Exception ?? throw new Exception("Unknown exception");
            
            return default;
        }
        
        public static async Task WhenAll(this IEnumerable<Task> tasks)
        {
            Task t = Task.WhenAll(tasks);
           
            try
            {
                await t;
                return;
            }
            catch (Exception e)
            {
                //ignore
            }
            
            if(t.Status != TaskStatus.Canceled)
                throw t.Exception ?? throw new Exception("Unknown exception");
        }
        
        public static Task UnityContinueWith(this Task task, Action<Task> continuationAction, 
            CancellationToken? cancellationToken = null)
        {
            return task.ContinueWith(continuationAction, cancellationToken ?? new CancellationToken(), 
                TaskContinuationOptions.None,
                TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}