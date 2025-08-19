func romanToInt(s string) int {
    val := func(c byte) (int, error) {
        switch c {
		case 'I':
			return 1, nil
		case 'V': 
			return 5, nil
		case 'X':
			return 10, nil
		case 'L':
			return 50, nil
		case 'C':
			return 100, nil
		case 'D':
			return 500, nil
		case 'M':
			return 1000, nil
		default: 
			return 0, errors.New(fmt.Sprintf(`Unexpected roman char: %c`, c))
        }
    }

    result := 0;
    prev := 0;

    for i := len(s) - 1; i >= 0; i-- {
        v, _ := val(s[i]);
        if v < prev {
            result -= v;
        } else {
            result += v;
        }
        prev = v;
    }
    
    return result;
}