using System.Collections.Generic;
using Eticaret.Dto.Slider;
using Eticaret.Entity;

namespace Eticaret.IL
{
    public interface ISliderManager : IGenericManager<Slider, SliderListDto, SliderEditDto>
    {
        List<SliderListDto> GetSlider();
    }
}
