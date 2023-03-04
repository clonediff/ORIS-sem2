import { Button } from "antd";
import { useEffect, useState } from "react";
import IntervalSlider from "./IntervalSlider";
import RadioGroup from "./RadioGroup";

const Filter = ({ filter, saveFiltersState, filters }) => {

    const { range, enumValues } = filter;
    const { min, max } = range ? range : {min: undefined, max: undefined}
    
    const [from, setFrom] = useState(min)
    const [to, setTo]  = useState(max)
    const [radioValue, setRadioValue] = useState('')
    const [saveFilters, setSaveFilters] = saveFiltersState

    useEffect(() => {
        if (saveFilters){
            let filterObj = {}
            if (radioValue !== '')
                filterObj.enumValue = radioValue
            if (range && (enumValues && radioValue !== '') || (!enumValues && (from !== min || to !== max))) {
                filterObj.from = from;
                filterObj.to = to;
            }
            filters(filterObj)
            setSaveFilters(false);
        }
    }, [saveFilters])

    const resetValues = (e) => {
        setFrom(min)
        setTo(max)
        setRadioValue('')
    }

    return (
        <>
            {
                range &&
                <IntervalSlider min={min} max={max} fromState={[from, setFrom]} toState={[to, setTo]}/>
            }
            {
                enumValues &&
                <RadioGroup values={enumValues} radioValueState={[radioValue, setRadioValue]}/>
            }
            <Button type="primary" onClick={resetValues}>Сбросить</Button>
        </>
    )
}

export default Filter;