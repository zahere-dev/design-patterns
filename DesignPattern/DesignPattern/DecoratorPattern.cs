using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.DesignPattern
{

    // The base interface
    public interface ILightsaber
    {
        void Assemble();
    }
    // Base class
    public abstract class Lightsaber: ILightsaber
    {
        public abstract void Assemble();
    }

    // Concrete implementation of the base class
    public class StandardLightsaber : Lightsaber
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling standard lightsaber");
        }
    }

    // Decorator class
    public class HiltDesignDecorator : Lightsaber
    {
        private Lightsaber _lightsaber;
        private string _hiltDesign;

        public HiltDesignDecorator(Lightsaber lightsaber, string hiltDesign)
        {
            _lightsaber = lightsaber;
            _hiltDesign = hiltDesign;
        }

        public override void Assemble()
        {
            _lightsaber.Assemble();
            Console.WriteLine($"Adding {_hiltDesign} hilt design to lightsaber");
        }
    }

    // Decorator class
    public class BladeColorDecorator : Lightsaber
    {
        private Lightsaber _lightsaber;
        private string _bladeColor;

        public BladeColorDecorator(Lightsaber lightsaber, string bladeColor)
        {
            _lightsaber = lightsaber;
            _bladeColor = bladeColor;
        }

        public override void Assemble()
        {
            _lightsaber.Assemble();
            Console.WriteLine($"Adding {_bladeColor} blade color to lightsaber");
        }
    }

}
