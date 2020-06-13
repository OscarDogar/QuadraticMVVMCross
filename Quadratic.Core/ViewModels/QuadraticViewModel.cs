using MvvmCross.Commands;
using MvvmCross.ViewModels;
using Quadratic.Core.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Quadratic.Core.ViewModels
{
    public class QuadraticViewModel : MvxViewModel
    {
        private readonly IQuadraticService _quadraticService;
        private double _a;
        private double _b;
        private double _c;
        private double _x1;
        private double _x2;
        private MvxCommand _calculateCommand;

        public QuadraticViewModel(IQuadraticService quadraticService)
        {
            _quadraticService = quadraticService;
        }

        public double A
        {
            get => _a;
            set => SetProperty(ref _a, value);
        }
        public double B
        {
            get => _b;
            set => SetProperty(ref _b, value);
        }
        public double C
        {
            get => _c;
            set => SetProperty(ref _c, value);
        }

        public double X1
        {
            get => _x1;
            set => SetProperty(ref _x1, value);
        }
        public double X2
        {
            get => _x2;
            set => SetProperty(ref _x2, value);
        }
        public override async Task Initialize()
        {
            await base.Initialize();

            A = 2;
            B = 8;
            C = 3;
            Calculate();
        }
        public ICommand CalculateCommand
        {
            get
            {
                _calculateCommand = _calculateCommand ?? new MvxCommand(Calculate);
                return _calculateCommand;
            }
        }
        private void Calculate()
        {
            X1 = _quadraticService.SolveQuadraticPositive(A, B, C);
            X2 = _quadraticService.SolveQuadraticNegative(A, B, C);
        }
    }
}
