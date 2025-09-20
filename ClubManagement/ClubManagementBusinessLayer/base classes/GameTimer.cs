using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubManagementBusinessLayer.base_classes
{
    public class GameTimer
    {
        private DateTime? _startTime;
        private TimeSpan _elapsed;
        public bool _isRunning;

        public bool IsRunning => _isRunning;

        public void Start()
        {
            _elapsed = TimeSpan.Zero;
            _startTime = DateTime.Now;
            _isRunning = true;
        }

        public void Pause()
        {
            if (_isRunning && _startTime.HasValue)
            {
                _elapsed += DateTime.Now - _startTime.Value;
                _startTime = null;
                _isRunning = false;
            }
        }

        public void Resume()
        {
            if (!_isRunning)
            {
                _startTime = DateTime.Now;
                _isRunning = true;
            }
        }

        public void Reset()
        {
            _elapsed = TimeSpan.Zero;
            _startTime = null;
            _isRunning = false;
        }

        public TimeSpan Elapsed
        {
            get
            {
                if (_isRunning && _startTime.HasValue)
                    return _elapsed + (DateTime.Now - _startTime.Value);
                else
                    return _elapsed;
            }
        }
    }

}
