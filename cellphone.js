const KEYPAD = {
    1: "&'(",
    2: "ABC",
    3: "DEF",
    4: "GHI",
    5: "JKL",
    6: "MNO",
    7: "PQRS",
    8: "TUV",
    9: "WXYZ",
    0: " ",
};


function oldPhonePad(input){
    let result = ""
    let count = 0
    let current = "";
    if(input[input.length - 1] !== "#"){
        input += "#"
    }

    for(let i=0;i<input.length;i++){

        const key = input[i]

        if(key === "#"){
            if(count > 0){
                const letter = extractLetter(current, count)
                result += letter;
            }
            break
        }

        if(key === "*"){
            count = 0
            current = ""
            continue
        }

        if(key === "0"){
            count = 0
            current = ""
            result += " "
        } 

        if(current === ""){
            current = key
            count++
        } else if (current === key){
            count++
        } else if (current !== key && key !== ""){
            if(current === " "){
                count = 1;
                current = ""
                continue
            }
            const letter = extractLetter(current, count)
            result += letter;
            current = key
            count = 1
        } else if (current === "  "){
            const letter = extractLetter(current, count)
            result += letter;
            current = ""
            count = 0
        }
    }
    return result
}

function extractLetter(current, count){
    const keyCharacters = KEYPAD[current]

    if(count > keyCharacters.length){
        count = (count % keyCharacters.length)
    }
    return keyCharacters[count - 1]
}


console.log(oldPhonePad("33#"));
console.log(oldPhonePad("227*#"));
console.log(oldPhonePad("4433555 555666#"));
console.log(oldPhonePad("8 88777444666*664#")); 
console.log(oldPhonePad("2222234000044458287843098243*z***1798624351978234198712342#"))

