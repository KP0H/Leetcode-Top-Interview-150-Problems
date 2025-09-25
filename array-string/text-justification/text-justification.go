func fullJustify(words []string, maxWidth int) []string {
	res := []string{}
	for i := 0; i < len(words); {
		j, lineLen := i, 0
		for j < len(words) && lineLen+len(words[j])+(j-i) <= maxWidth {
			lineLen += len(words[j])
			j++
		}

		gaps := j - i - 1
		lastLine := j == len(words)

		if lastLine || gaps == 0 {
			line := strings.Join(words[i:j], " ")
			if len(line) < maxWidth {
				line += strings.Repeat(" ", maxWidth-len(line))
			}
			res = append(res, line)
		} else {
			totalSpaces := maxWidth - lineLen
			spaceEach := totalSpaces / gaps
			extra := totalSpaces % gaps

			var b strings.Builder
			b.Grow(maxWidth)
			for k := i; k < j; k++ {
				b.WriteString(words[k])
				if k < j-1 {
					spaces := spaceEach
					if k-i < extra {
						spaces++
					}
					b.WriteString(strings.Repeat(" ", spaces))
				}
			}
			res = append(res, b.String())
		}

		i = j
	}
	return res
}