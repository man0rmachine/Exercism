export const toRna = (s) => {
  if (s.length == 0) { return ""; }
  else { var newString = '';
    for (let c of s){
      switch (c){
        case 'G': newString += 'C'; break;
        case 'A': newString += 'U'; break;
        case 'C': newString += 'G'; break;
        case 'T': newString += 'A'; break;
      }
    } return newString; } };