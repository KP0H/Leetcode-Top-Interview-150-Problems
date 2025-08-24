func wordPattern(pattern string, s string) bool {
    words := strings.Split(s, ' ');

    if len(pattern) != len(words) {
		return false;
	}

    p2w := make(map[byte]string);
    w2p := make(map[string]byte);

    for i := 0; i < len(pattern); i++ {
        p := pattern[i];
        w := words[i];

        if mw, ok := p2w[p]; ok {
            if mw != w { return false }
        } else {
            if mp, ok := w2p[w]; ok && mp != p { return false; }
            p2w[p] = w;
            w2p[w] = p;
        }
    }

    return true;
}